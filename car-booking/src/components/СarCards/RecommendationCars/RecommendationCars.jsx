import React, { useEffect, useState } from 'react';
import CarCard from "../CarCard/CarCard";

const RecommendationCars = ({ searchQuery }) => {
  const [cardsOfCars, setCars] = useState([]);
  useEffect(() => {
    fetch("http://www.efimov.somee.com/api/api/Cars/all")
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
  const filteredCars = cardsOfCars.filter((car) =>
    searchQuery
      ? car.name.toLowerCase().includes(searchQuery.toLowerCase())
      : true
  );

  return (
    <>
      <h4 className="highlited-gray">Recommendation cars</h4>
      <div className="recomendation-cars row">
        {filteredCars.map(car => (
          <div className="col-10 offset-1 col-lg-6 offset-lg-0 col-xl-3 car p-3" key={car.id}>
            <CarCard
              id = {car.id}
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
        <p className="highlited-gray col-1 offset-4 align-items-center d-flex justify-content-end">{filteredCars.length}</p>
      </div>
    </>
  );
};

export default RecommendationCars;