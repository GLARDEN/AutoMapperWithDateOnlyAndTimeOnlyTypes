using TestAuditTrail;

namespace AutoMapperWithDateOnlyAndTimeOnlyTypes.Model;

public class Model
{
    public Guid Id { get;private set; }
    public DateOnly Date { get; private set; }
    public TimeOnly Time { get; private set; }
    public DateRange DateRange { get; private set; }

    public Model(Guid id, DateOnly date, TimeOnly time, DateRange dateRange)
    {
        Id=id;
        Date=date;
        Time=time;
        DateRange=dateRange;
    }

}
