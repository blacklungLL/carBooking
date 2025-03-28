import React from 'react';
import CarCard from "../CarCard/CarCard";
import CarsData from "../CarsData";

const RecommendationCars = ({ searchQuery }) => {
  // Фильтрация данных
  const filteredCars = CarsData.filter((car) =>
    searchQuery
      ? car.name.toLowerCase().includes(searchQuery.toLowerCase())
      : true // Если searchQuery пустой, возвращаем все машины
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