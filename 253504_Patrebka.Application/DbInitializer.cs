using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _253504_Patrebka.Application
{
    public static class DbInitializer
    {
        public static async Task Initialize(IServiceProvider services)
        {
            var unitOfWork = services.GetRequiredService<IUnitOfWork>();
            await unitOfWork.DeleteDataBaseAsync();
            await unitOfWork.CreateDataBaseAsync();

            await unitOfWork.CarRepository.AddAsync(new Car(1, "Rolls Royce", "UK", "Automatic", 1990));
            await unitOfWork.CarRepository.AddAsync(new Car(2, "Mercedes G-klasse", "Germany", "Automatic", 2005));
            await unitOfWork.CarRepository.AddAsync(new Car(3, "Lada Vesta", "Russia", "Manual Transmission", 2017));

            await unitOfWork.SaveAllAsync();

            await unitOfWork.AdvertisementRepository.AddAsync(new Advertisement(1, "Rare Premium Car!", new DateTime(2020, 6, 14), "Beautiful and rare silver spur from 1990",
                "Resources/Images/rolls_royce.jpg", 1, 15000));
            await unitOfWork.AdvertisementRepository.AddAsync(new Advertisement(2, "Rolls Royce Silver Spur 1990", new DateTime(2023, 3, 20), "Super rare red color 1/10, was used by princess Diana",
                "Resources/Images/rolls_royce1.jpg", 1, 20000));
            await unitOfWork.AdvertisementRepository.AddAsync(new Advertisement(3, "Wrecked Royce ASAP", new DateTime(2021, 6, 24), "Front wheel is wrecked, needs engine repair",
                "Resources/Images/rolls_royce2.jpg", 1, 3000));

            await unitOfWork.AdvertisementRepository.AddAsync(new Advertisement(4, "Mercedes 2005", new DateTime(2023, 5, 12), "was not painted or wrecked, was driven by babushka to church on sundays",
                "Resources/Images/merc.jpg", 2, 21000));
            await unitOfWork.AdvertisementRepository.AddAsync(new Advertisement(5, "Audi Minsk", new DateTime(2022, 4, 15), "Clean history, new coilovers and wheels, no crashes, native mileage",
                "Resources/Images/merc2.jpg", 2, 18000));

            await unitOfWork.AdvertisementRepository.AddAsync(new Advertisement(6, "Vesta", new DateTime(2024, 5, 25), "Red shitbox",
                "Resources/Images/vesta.jpg", 3, 8000));
            await unitOfWork.AdvertisementRepository.AddAsync(new Advertisement(7, "Lada Vesta", new DateTime(2024, 4, 17), "Real car for real men",
                "Resources/Images/vesta1.jpg", 3, 7800));
            await unitOfWork.AdvertisementRepository.AddAsync(new Advertisement(8, "Vesta URGENTLY", new DateTime(2024, 6, 19), "NO bargain, price is already minimal",
                "Resources/Images/vesta3.jpg", 3, 5800));

            await unitOfWork.SaveAllAsync();
        }
    }
}
