using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarProject.Common.Mapping
{
    public static class MyAutoMapper<Tsource, TDestination>
    {
        //Bir mapper olarak, kendi map yapılandırmasına sahip bir mapper oluşturdum.
        private static Mapper _myMapper = new Mapper(new MapperConfiguration(
            cfg =>
                cfg.CreateMap<Tsource, TDestination>().ReverseMap()
        ));
        /// <summary>
        /// Parametre olarak Map ile çevilecek olan data model verisini ister
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static TDestination Map(Tsource source)
        {
            return _myMapper.Map<TDestination>(source);
            //return _myMapper.Map<TDestination>(source);
        }
        /// <summary>
        /// Data Model Listesini parametre olarak ister
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static IEnumerable<TDestination> MapList(List<Tsource> source)//Liste olarak maplemek için de bu methodu static olarak kullanırız. 
        {
            var list = new List<TDestination>();
            source.ForEach(x => { list.Add(Map(x)); });
            return list;
        }
    }
}
