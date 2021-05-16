using AutoMapper;
using Domain.Contract.Models;

namespace Repository.Setup
{
    public class Profiles: Profile
    {
        public Profiles()
        {
            CreateMap<Staff, Entities.Staff>();
            CreateMap<Entities.Staff, Staff>();
        }
    }
}
