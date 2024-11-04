﻿using AutoMapper;
using LeaveManagmentSystem.Web.Data;
using LeaveManagmentSystem.Web.Models.LeaveTypes;

namespace LeaveManagmentSystem.Web.MappingProfiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() {
            CreateMap<LeaveType, LeaveTypeReadOnlyVM>();
            CreateMap<LeaveTypeCreateVM, LeaveType>();
            CreateMap<LeaveTypeEditVM, LeaveType>().ReverseMap();
        }
    }
}