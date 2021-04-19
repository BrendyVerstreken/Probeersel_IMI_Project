using AutoMapper;
using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Imi.Project.Api.Core.Mapping
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Movie, MovieResponseDto>()
                .ForMember(dest => dest.Genres,
                    opt => opt.MapFrom(src => src.MovieGenres
                    .Select(mg => new GenreResponseDto
                    {
                        Id = mg.GenreId,
                        Name = mg.Genre.Name
                    })));

            CreateMap<Movie, MovieResponseDto>()
                .ForMember(dest => dest.LentOuts,
                    opt => opt.MapFrom(src => src.MovieLentouts
                    .Select(mg => new LentOutResponseDto
                    {
                        Id = mg.LentOutId,
                        Name = mg.LentOut.Name
                    })));

            CreateMap<Genre, GenreResponseDto>();

            CreateMap<Director, DirectorResponseDto>();

            CreateMap<LentOut, LentOutResponseDto>();

            CreateMap<Productionhouse, ProductionHouseResponseDto>();

            CreateMap<MovieRequestDto, Movie>();
            CreateMap<GenreRequestDto, Genre>();
            CreateMap<DirectorRequestDto, Director>();
            CreateMap<LentOutRequestDto, LentOut>();
            CreateMap<ProductionhouseRequestDto, Productionhouse>();
        }
    }
}
