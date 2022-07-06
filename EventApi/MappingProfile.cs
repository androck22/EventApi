using AutoMapper;
using EventApi.Contracts.Models.Meetup;
using EventApi.Contracts.Models.Sponsor;
using EventApi.Data.Models;

namespace EventApi
{
    /// <summary>
    /// Настройки маппинга всех сущностей приложения
    /// </summary>
    public class MappingProfile : Profile
    {
        /// <summary>
        /// В конструкторе настроим соответствие сущностей при маппинге
        /// </summary>
        public MappingProfile()
        {
            CreateMap<AddMeetupRequest, Meetup>();
            CreateMap<Meetup, MeetupView>();
            CreateMap<Meetup, GetMeetupByIdResponse>();
            CreateMap<Sponsor, SponsorView>();
            CreateMap<Sponsor, GetSponsorByIdResponse>();
        }
    }
}
