using System;
using LootLocker;
using LootLocker.Requests;
using Newtonsoft.Json;

namespace UnitySdkTest
{
    public class LootLockerInitialAuthRequest
    {
        public string email { get; set; }
        public string password { get; set; }
    }

    public class LootLockerUser
    {
        public string name { get; set; }
        public LootLockerOrganisation[] organisations { get; set; }
    }

    public class LootLockerOrganisation
    {
        public int id { get; set; }
        public string name { get; set; }
        public LootLockerGameAndDevelopment[] games { get; set; }
    }
    public class LootLockerGameAndDevelopment
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool sandbox_mode { get; set; }
        public bool is_demo;
        public LootLockerGame development { get; set; }
    }
    public class LootLockerGame
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool sandbox_mode { get; set; }

        public bool is_demo;
    }

    public class LootLockerAuthResponse : LootLockerResponse
    {
        public bool success { get; set; }
        public string auth_token { get; set; }
        public LootLockerUser user { get; set; }
        public string mfa_key { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            LootLockerServerManager serverManager = new LootLockerServerManager();
            LootLockerConfig config = LootLockerConfig.Get();
            config.url = "https://3jkp0c3e.api.lootlocker.io/";
            config.apiKey = args[0];

            bool isRunning = true;

            /*
            // This does not work for some reason. Have not investigated why.
            string playerIdentifier = "unique_player_identifier_here";
            LootLockerSDKManager.StartSession(playerIdentifier, (response) =>
            {
                isRunning = false;
                if (response.success)
                {
                    Console.WriteLine("Success");
                }
                else
                {
                    Console.WriteLine("Fail");
                }
            });*/

            // Copied admin auth logic from Sample app to have something I know works.
            EndPointClass initialAuthenticationRequest = new EndPointClass("v1/session", LootLockerHTTPMethod.POST);
            {
                var data = new LootLockerInitialAuthRequest();
                data.email = args[1];
                data.password = args[2];

                string json = "";
                if (data == null) return;
                else json = JsonConvert.SerializeObject(data);

                EndPointClass endPoint = initialAuthenticationRequest;

                LootLockerServerManager.CheckInit();

                LootLockerServerRequest.CallAPI(endPoint.endPoint, endPoint.httpMethod, json, (serverResponse) =>
                {
                    var response = new LootLockerAuthResponse();
                    Console.WriteLine(serverResponse.text);

                    if (string.IsNullOrEmpty(serverResponse.Error))
                    {
                        response = JsonConvert.DeserializeObject<LootLockerAuthResponse>(serverResponse.text);

                        if (response.mfa_key == null)
                        {
                            LootLockerConfig.current.adminToken = response.auth_token;
                        }

                        response.text = serverResponse.text;
                        response.success = serverResponse.success;
                    }
                    else
                    {
                        response.success = serverResponse.success;
                        response.Error = serverResponse.Error;
                        response.statusCode = serverResponse.statusCode;
                    }
                    isRunning = false;
                }, useAuthToken: false, callerRole: LootLocker.LootLockerEnums.LootLockerCallerRole.Admin);
            }

            // Mini update loop that updates coroutines
            while (isRunning)
            {
                MockUnityEngine.Runtime.Tick();
                System.Threading.Thread.Sleep(0);
            }
        }
    }
}
