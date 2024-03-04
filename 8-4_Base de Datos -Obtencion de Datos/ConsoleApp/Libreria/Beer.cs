using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Beer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }

        public Beer(int id, string name, int brandId)
        {
            Id = id;
            Name = name;
            BrandId = brandId;
        }

        //Sobrecarga de Constructor, para pasarle solo estos datos, ya que la id se genera automaticamente en la Db ahora
        public Beer(string name, int brandId)
        {
            Name = name;
            BrandId = brandId;
        }
        //public override string ToString()
        //{
        //    return $"Id: {Id}, Name: {Name}, BrandId: {BrandId}";
        //}
    }
}
