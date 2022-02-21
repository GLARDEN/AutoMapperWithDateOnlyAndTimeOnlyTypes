// See https://aka.ms/new-console-template for more information
using AutoMapper;

using AutoMapperWithDateOnlyAndTimeOnlyTypes.Model;

using TestAuditTrail;

var config = new MapperConfiguration(cfg => {
    cfg.CreateMap<Model, ModelDTO>();
});
IMapper mapper = config.CreateMapper();

var dateRange = new DateRange(DateTime.Now, DateTime.Now.AddDays(1));
var model = new Model(Guid.NewGuid(), DateOnly.FromDateTime(DateTime.Now), TimeOnly.FromDateTime(DateTime.Now), dateRange);

var mapped = mapper.Map<Model, ModelDTO>(model);

Console.WriteLine($"{mapped.Id} - {mapped.Date} - {mapped.Time} - {mapped.DateRange.Start} - {mapped.DateRange.End}");
Console.ReadLine();
