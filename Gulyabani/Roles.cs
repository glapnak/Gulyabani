using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gulyabani
{
    public class GameRoles
    {
        public string Name { get; set; }
        public int[] Limit { get; set; }
        public int[] Count { get; set; }
    }

    public class SelectedRoles
    {
        public string Name { get; set; }
        public int Count { get; set; }
    }


    public class Roles
    {
        private List<GameRoles> _gameRoles = new List<GameRoles>();
        public List<GameRoles> GameRoles { get { return _gameRoles; } }


        public Roles()
        {
            GameRoles role = new GameRoles();
            //Gülyabani
            role.Name = "Gulyabani";
            role.Limit = new int[] { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            role.Count = new int[] { 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 4 };
            _gameRoles.Add(role);


            role = new GameRoles();
            //Küçük Enişte
            role.Name = "Küçük Enişte";
            role.Limit = new int[] { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            role.Count = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            _gameRoles.Add(role);

            role = new GameRoles();
            //Uyur Gezer
            role.Name = "Uyur Gezer";
            role.Limit = new int[] { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            role.Count = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, };
            _gameRoles.Add(role);

            role = new GameRoles();
            //Çakma Gulyabani
            role.Name = "Çakma Gulyabani";
            role.Limit = new int[] { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            role.Count = new int[] { 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, };
            _gameRoles.Add(role);

            role = new GameRoles();
            //Arkadaş
            role.Name = "Arkadaş";
            role.Limit = new int[] { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            role.Count = new int[] { 2, 2, 1, 2, 2, 1, 0, 0, 1, 1, 2, 3, 2, };
            _gameRoles.Add(role);

            role = new GameRoles();
            //ÇöpÇatan
            role.Name = "ÇöpÇatan";
            role.Limit = new int[] { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            role.Count = new int[] { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, };
            _gameRoles.Add(role);

            role = new GameRoles();
            //Depresif
            role.Name = "Depresif";
            role.Limit = new int[] { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            role.Count = new int[] { 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, };
            _gameRoles.Add(role);

            role = new GameRoles();
            //Ağır Abi
            role.Name = "Ağır Abi";
            role.Limit = new int[] { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            role.Count = new int[] { 0, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, };
            _gameRoles.Add(role);

            role = new GameRoles();
            //Uyur Gezer'in Pıtırcığı
            role.Name = "Uyur Gezer'in Pıtırcığı";
            role.Limit = new int[] { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            role.Count = new int[] { 0, 0, 0, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, };
            _gameRoles.Add(role);

            role = new GameRoles();
            //Seri Katil
            role.Name = "Seri Katil";
            role.Limit = new int[] { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            role.Count = new int[] { 0, 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, };
            _gameRoles.Add(role);

            role = new GameRoles();
            //Gül Baba
            role.Name = "Gül Baba";
            role.Limit = new int[] { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            role.Count = new int[] { 0, 0, 0, 0, 0, 0, 1, 0, 1, 1, 1, 1, 1, };
            _gameRoles.Add(role);

            role = new GameRoles();
            //Anne 
            role.Name = "Anne";
            role.Limit = new int[] { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            role.Count = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, };
            _gameRoles.Add(role);

            role = new GameRoles();
            //Atarlı Çöpçü
            role.Name = "Atarlı Çöpçü";
            role.Limit = new int[] { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            role.Count = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, };
            _gameRoles.Add(role);

            role = new GameRoles();
            //Dedikoducu
            role.Name = "Dedikoducu";
            role.Limit = new int[] { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            role.Count = new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, };
            _gameRoles.Add(role);

            role = new GameRoles();
            //Kanka
            role.Name = "Kanka";
            role.Limit = new int[] { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            role.Count = new int[] { 0, 0, 0, 0, 0, 2, 2, 2, 2, 2, 2, 2, 2, };
            _gameRoles.Add(role);

            role = new GameRoles();
            //Keko Gulyabani
            role.Name = "Keko Gulyabani";
            role.Limit = new int[] { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            role.Count = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
            _gameRoles.Add(role);

            role = new GameRoles();
            //Satanist Gotik Emo
            role.Name = "Satanist Gotik Emo";
            role.Limit = new int[] { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            role.Count = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
            _gameRoles.Add(role);

            role = new GameRoles();
            //Sayko
            role.Name = "Sayko";
            role.Limit = new int[] { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            role.Count = new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, };
            _gameRoles.Add(role);
        }
    }
}
