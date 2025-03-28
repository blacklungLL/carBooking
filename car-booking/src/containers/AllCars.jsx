import React, { useState, useEffect } from 'react';
import Filter from '../components/Filter';
import CategoryCarCards from '../components/СarCards/CategoryCarCards';
import Options2 from '../components/SecOpt';
import { useOutletContext } from 'react-router-dom';

const AllCars = () => {
  const { searchQuery } = useOutletContext();

  // Инициализация состояний из localStorage
  const [activeTypes, setActiveTypes] = useState(() => {
    try {
      const savedTypes = localStorage.getItem('activeTypes');
      return savedTypes ? JSON.parse(savedTypes) : [];
    } catch (error) {
      console.error('Error parsing activeTypes:', error);
      return [];
    }
  });

  const [activeCapacities, setActiveCapacities] = useState(() => {
    try {
      const savedCapacities = localStorage.getItem('activeCapacities');
      return savedCapacities ? JSON.parse(savedCapacities) : [];
    } catch (error) {
      console.error('Error parsing activeCapacities:', error);
      return [];
    }
  });

  const [price, setPrice] = useState(() => {
    try {
      const savedPrice = localStorage.getItem('price');
      return savedPrice ? parseFloat(savedPrice) : 100;
    } catch (error) {
      console.error('Error parsing price:', error);
      return 100;
    }
  });

  // Сохранение состояний в localStorage
  useEffect(() => {
    try {
      localStorage.setItem('activeTypes', JSON.stringify(activeTypes));
    } catch (error) {
      console.error('Error saving activeTypes:', error);
    }
  }, [activeTypes]);

  useEffect(() => {
    try {
      localStorage.setItem('activeCapacities', JSON.stringify(activeCapacities));
    } catch (error) {
      console.error('Error saving activeCapacities:', error);
    }
  }, [activeCapacities]);

  useEffect(() => {
    try {
      localStorage.setItem('price', price.toString());
    } catch (error) {
      console.error('Error saving price:', error);
    }
  }, [price]);

  return (
    <div className="AllCars">
      <Filter
        activeTypes={activeTypes}
        setActiveTypes={setActiveTypes}
        activeCapacities={activeCapacities}
        setActiveCapacities={setActiveCapacities}
        price={price}
        setPrice={setPrice}
      />
      <div className="blocks">
        <Options2 />
        <CategoryCarCards
          searchQuery={searchQuery}
          activeTypes={activeTypes}
          activeCapacities={activeCapacities}
          price={price}
        />
      </div>
    </div>
  );
};

export default AllCars;