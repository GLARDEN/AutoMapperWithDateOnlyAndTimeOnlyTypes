using TestAuditTrail;

namespace AutoMapperWithDateOnlyAndTimeOnlyTypes.Model;

public class ModelDTO
{
    public Guid Id { get;  set; }
    public DateOnly Date { get;  set; }
    public TimeOnly Time { get;  set; }
    public DateRange DateRange { get; set; }


}
