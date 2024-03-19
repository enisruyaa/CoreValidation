using CoreValidation_2Tekrar.Models.Enums;

namespace CoreValidation_2Tekrar.Models.Entities
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            CreateDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }

        public int ID { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? ModifedDate { get; set; }

        public DateTime? DeletedDate { get; set; }

        public DataStatus Status { get; set; }
    }
}
