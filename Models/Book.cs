using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Book
    {
        public int Id { get; set; } // primarni kljuc
        public string Title { get; set; } // naslov knjige

        /*Knjiga se moze uzeti ako jeste available, inace ne moze jer
         neki korisnik je nije vratio*/
        [Display(Name = "Availability")]
        public string Available { get; set; }


        /*Datum kada treba vratiti knjigu ako nije vracena, a ako je
         u biblioteci onda je podatak NULL*/
        [Display(Name = "Return Date")]
        [DataType(DataType.Date)]
        public DateTime? ReturnDate { get; set; }

        /*Bitno je da napravimo controller za Books, to se radi dodavanjem
         novog scaffolded item-a u folderu Controllers.
        Scaffolding je automatsko pravljenje CRUD stanica.
        
         Nakon toga idemo na EF Core migrations. Time pravimo bazu podataka*/

        /* Migracija koriscena: Add-Migration InitialCreate -Context LibraryContext
         * Kucati DbContext u Package Menager Console da bi videli koje DbContext-e
         * ima nas projekat
         */
    }
}
