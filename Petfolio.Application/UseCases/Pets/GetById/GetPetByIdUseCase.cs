using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetById;

public class GetPetByIdUseCase
{
    public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson 
        {
            Id = id, 
            Name = "Francisco", 
            Type = Communication.Enums.PetType.Dog, 
            BirthDay = new DateTime(year: 2024, month: 05, day: 17 ) 
        };
    }
}
