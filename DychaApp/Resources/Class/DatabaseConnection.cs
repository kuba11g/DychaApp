using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;

namespace DychaApp.Resources
{
    class DatabaseConnection
    {
        private static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "YOUR_FIREBASE_AUTH_SECRET",
            BasePath = "YOUR_FIREBASE_BASE_PATH"
        };
        private static IFirebaseClient client = new FireSharp.FirebaseClient(config);

        private static int GetCounter()
        {
            FirebaseResponse checkCount = client.Get("DychaApp/UserCount");
            return checkCount.ResultAs<int>();
        }

        public static int GetWalletCounter(int ID)
        {
            FirebaseResponse getWalletCount = client.Get($"DychaApp/{ID}/Wallet/WalletCount");
            return getWalletCount.ResultAs<int>();
        }

        private static string GetUsername(int i)
        {
            FirebaseResponse checkUsername = client.Get($"DychaApp/{i}/Username");
            return checkUsername.ResultAs<string>();
        }

        private static string GetPassword(int i)
        {
            FirebaseResponse checkPassword = client.Get($"DychaApp/{i}/Password");
            return checkPassword.ResultAs<string>();
        }

        public static bool Register(string name, string surname, string email, string username, string password)
        {
            int counter = GetCounter();

            var InputInfo = new UserInfo
            {
                ID = counter,
                Name = name,
                Surname = surname,
                Email = email,
                Username = username,
                Password = password
            };

            for (int i = 0; i <= counter; i++)
            {
                FirebaseResponse checkDuplicate = client.Get($"DychaApp/{i}/Username");
                string duplicatedUsername = checkDuplicate.ResultAs<string>();

                if (duplicatedUsername == InputInfo.Username)
                    return false;
            }

            var Result = client.Set($"DychaApp/{counter}", InputInfo);
            var Wallet = client.Set($"DychaApp/{counter}/Wallet", "");
            var WalletCount = client.Set($"DychaApp/{counter}/Wallet/WalletCount", 0);

            var CounterAdd = client.Set("DychaApp/UserCount", ++counter);

            return true;
        }

        public static bool Login(string username, string password)
        {
            int counter = GetCounter();

            for (int i = 0; i <= counter; i++)
                if (GetUsername(i) == username && GetPassword(i) == password)
                {
                    Properties.Settings.Default.ID = i;
                    Properties.Settings.Default.Save();

                    return true;
                }

            return false;
        }

        public static void AddToWallet(string symbol, double volume, double currentPrice)
        {
            int userID = Properties.Settings.Default.ID;
            int walletCounter = GetWalletCounter(userID);

            var WalletSymbol = client.Set($"DychaApp/{userID}/Wallet/Symbol/{walletCounter}", symbol);
            var WalletVolume = client.Set($"DychaApp/{userID}/Wallet/Volume/{walletCounter}", volume);
            var WalletCurrentPrice = client.Set($"DychaApp/{userID}/Wallet/CurrentPrice/{walletCounter}", currentPrice);

            var walletCounterAdd = client.Set($"DychaApp/{userID}/Wallet/WalletCount", ++walletCounter);
        }

        public static List<Tuple<string, double, double>> ShowWallet(int i)
        {
            List<Tuple<string, double, double>> wallet = new List<Tuple<string, double, double>>();
            int userID = Properties.Settings.Default.ID;

            wallet.Add(new Tuple<string, double, double>(
                client.Get($"DychaApp/{userID}/Wallet/Symbol/{i}").ResultAs<string>(),
                client.Get($"DychaApp/{userID}/Wallet/Volume/{i}").ResultAs<double>(),
                client.Get($"DychaApp/{userID}/Wallet/CurrentPrice/{i}").ResultAs<double>()));

            return wallet;
        }
    }

    internal class UserInfo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
