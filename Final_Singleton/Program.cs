using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Newtonsoft.Json;

namespace Singleton
{
    static class Program
    {
        public class Player
        {
            public string player_name = "";
            public int level = 0;
            public int hp = 0;
            public List<string> inventory = new List<string>();
            public string license_key = "";

            private Player()
            {

            }

            private static Player instance = new Player();

            public static Player GetInstance()
            {
                return instance;
            }

            public void OpenPlayerFile(string filename)
            {
                StreamReader input = new StreamReader(filename);
                string sInput = input.ReadToEnd();
                input.Close();

                instance = JsonConvert.DeserializeObject<Player>(sInput);
            }

            public void WritePlayerFile(string filename)
            {
                string sOutput = JsonConvert.SerializeObject(instance);
                
                StreamWriter output = new StreamWriter(filename);
                output.Write(sOutput);
                output.Close();
                
            }
        }

        static void Main(string[] args)
        {
            Player player = Player.GetInstance();

            player.OpenPlayerFile(args[0]);
            player.WritePlayerFile(args[1]);
        }
    }
}