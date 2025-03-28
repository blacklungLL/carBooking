import CarCard from "../CarCard/CarCard";
import cars from "../../../data/cars";
import React from 'react';

const PopularCars = ({ searchQuery }) => {
    console.log('Current Search Query:', searchQuery);
    const filteredCars = cars.filter((car) =>
      searchQuery
        ? car.name.toLowerCase().includes(searchQuery.toLowerCase())
        : true // Если searchQuery пустой, возвращаем все машины
);

    return (
        <>
            <div className="text">
                <h4 className="highlited-gray">Popular cars</h4>
                <a href="/Category" className="view">View All</a> 
            </div>
            <div className="popular-cars row">
                {filteredCars.slice(0, 4).map(car => (
                    <div key={car.id} className="col-10 offset-1 col-lg-6 offset-lg-0 col-xl-3 car p-3">
                        <CarCard
                            id = {car.id}
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
        </>
    );
};

export default PopularCars;