import React, { useEffect, useState } from 'react';
import CarCard from "./CarCard/CarCard";

function CategoryCarCards({ searchQuery, activeTypes, activeCapacities, price }) {
  const [cardsOfCars, setCars] = useState([]);
  useEffect(() => {
    fetch("http://localhost:5156/api/Cars/all")
      .then((response) => {
        return response.json();
      })
      .then((data) => {
        setCars(data);
      })
      .catch((error) => {
        console.error("Ошибка при загрузке данных:", error);
      });
  }, []);

  const filteredCars = cardsOfCars.filter((car) => {
    const matchesSearch = searchQuery
      ? car.name.toLowerCase().includes(searchQuery.toLowerCase())
      : true;

    const matchesType = activeTypes.length > 0
      ? activeTypes.some((type) => type === car.category)
      : true;

    const matchesCapacity = activeCapacities.length > 0
      ? activeCapacities.some((capacity) => capacity === `${car.spaces} Person`)
      : true;

    const matchesPrice = car.price <= price;

    return matchesSearch && matchesType && matchesCapacity && matchesPrice;
  });

  return (
    <>
      <div className="cars-row">
        {filteredCars.map((car) => (
          <div className="col-10 offset-1 col-md-4 offset-md-0 p-3" key={car.id}>
            <CarCard
              id={car.id}
              name={car.name}
              category={car.category}
              img={car.img}
              liters={car.liters}
              transmission={car.transmission}
              spaces={car.spaces}
              price={car.price}
            />
          </div>
        ))}
      </div>
      <div className="row">
        <a className="abutton col-2 offset-5 my-4">Show more cars</a>
        <p className="highlited-gray col-1 offset-4 align-items-center d-flex justify-content-end">
          {filteredCars.length}
        </p>
      </div>
    </>
  );
}

export default CategoryCarCards;