﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ManageRoles.Models;
using ManageRoles.ViewModels;

namespace ManageRoles.MapperConfig
{
    public class AutoMapperConfiguration
    {
        public static void Config()
        {
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<SubMenuMasterCreate, SubMenuMaster>()
                    .ForMember(dest => dest.SubMenuName, opt => opt.MapFrom(src => src.SubMenuName))
                    .ForMember(dest => dest.ActionMethod, opt => opt.MapFrom(src => src.ActionMethod))
                    .ForMember(dest => dest.ControllerName, opt => opt.MapFrom(src => src.ControllerName))
                    .ForMember(dest => dest.MenuId, opt => opt.MapFrom(src => src.MenuId))
                    .ForMember(dest => dest.SubMenuId, opt => opt.MapFrom(src => src.SubMenuId))
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                    .ForMember(dest => dest.CreateDate, opt => opt.Ignore())
                    .ForMember(dest => dest.UserId, opt => opt.Ignore());

                cfg.CreateMap<SubMenuMaster, SubMenuMasterViewModel>();
                cfg.CreateMap<UsermasterView, Usermaster>();
                cfg.CreateMap<AssignRoleViewModel, SavedMenuRoles>();
                cfg.CreateMap<AssignRoleViewModelSubMenu, SavedSubMenuRoles>();
                cfg.CreateMap<SavedAssignedRoles, AssignViewUserRoleModel>();

                cfg.CreateMap<CreateUserViewModel, Usermaster>()
                    .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                    .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                    .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName))
                    .ForMember(dest => dest.MobileNo, opt => opt.MapFrom(src => src.MobileNo))
                    .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender))
                    .ForMember(dest => dest.EmailId, opt => opt.MapFrom(src => src.EmailId))
                    .ForMember(dest => dest.Status, opt => opt.Ignore())
                    .ForMember(dest => dest.CreateDate, opt => opt.Ignore())
                    .ForMember(dest => dest.UserId, opt => opt.Ignore());
            });
        }
    }
}