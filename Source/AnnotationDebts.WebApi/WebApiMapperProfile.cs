using AutoMapper;
using AnnotationDebts.Domain.Models;
using AnnotationDebts.WebApi.Dtos;

namespace AnnotationDebts.WebApi
{
    public class WebApiMapperProfile : Profile
    {
        public WebApiMapperProfile()
        {
            CreateMap<Filme, FilmesGetResult>();
            CreateMap<FilmesGet, Pesquisa>();
        }
    }
}
