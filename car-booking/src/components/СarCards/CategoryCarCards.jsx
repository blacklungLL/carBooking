import React, { useEffect, useState } from 'react';
import CarCard from "./CarCard/CarCard";

function CategoryCarCards({ searchQuery, activeTypes, activeCapacities, price }) {
  const [cardsOfCars, setCars] = useState([]);

  useEffect(() => {
    const queryParams = new URLSearchParams();
    if (activeTypes.length > 0) {
      queryParams.set('types', activeTypes.join(','));
    }
    if (activeCapacities.length > 0) {
      queryParams.set('capacities', activeCapacities.map(capacity => parseInt(capacity.split(' ')[0])).join(','));
    }
    if (price !== 100) {
      queryParams.set('maxPrice', price);
    }
    if (searchQuery) {
      queryParams.set('name', searchQuery);
    }

    fetch(`http://efimov.somee.com/api/Cars/filter?${queryParams.toString()}`)
      .then((response) => response.json())
      .then((data) => setCars(data))
      .catch((error) => console.error("Ошибка при загрузке данных:", error));
  }, [activeTypes, activeCapacities, price, searchQuery]);

  return (
    <>
      <div className="cars-row">
        {cardsOfCars.map((car) => (
          <div className="col-10 offset-1 col-md-4 offset-md-0 p-3" key={car.id}>
            <CarCard
              id={car.id}
              name={car.name}
              cathegory={car.category}
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
          {cardsOfCars.length}
        </p>
      </div>
    </>
  );
}

export default CategoryCarCards;