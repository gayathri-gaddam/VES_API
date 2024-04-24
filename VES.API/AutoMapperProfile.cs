using AutoMapper;
using VES.API.Models.Domain;
using VES.API.Models.DTO;

namespace VES.API
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Notice, NoticeDTO>();
            CreateMap<PastDue, PastDueDTO>();
            CreateMap<LFManagement,LFManagementDTO>();
            CreateMap<PBDTO, TempDTO>();
        }
    }
}
