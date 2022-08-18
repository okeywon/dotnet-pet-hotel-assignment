using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace pet_hotel
{
    public enum PetBreedType 
    {
        GermanSheppard,
        Dalmation,
        PitBull,
        Lab,
        Retriever,
    }
    public enum PetColorType 
    {
        Sulticolor,
        Solid,
        Spotted,
        Striped,
    }
    public class Pet 
    {
        public int id {get; set;}
        public string name {get; set;}
        public string description {get; set;}

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PetBreedType type {get; set;}

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PetColorType color {get; set;}

        [ForeignKey("ownedBy")]
        public int ownedById {get; set;}
        public PetOwner ownedBy {get; set;}
    }
}
