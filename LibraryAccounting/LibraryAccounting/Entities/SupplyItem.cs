using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryAccounting.Entities
{
    public class SupplyItem
    {
        [Key]
        public int Id { get; private set; }

        [Required]
        [ForeignKey("Supply")]
        public int SupplyId { get; private set; }

        [Required]
        [ForeignKey("LiteraryItem")]
        public int LiteraryItemId { get; private set; }

        [Required]
        public int Count { get; private set; }

        protected SupplyItem() { }

        public static SupplyItem CreateElement(int id, int literaryItemId, int count)
        {
            return new SupplyItem
            {
                Id = id,
                LiteraryItemId = literaryItemId,
                Count = count
            };
        }
    }
}