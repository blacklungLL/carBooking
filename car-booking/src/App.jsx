import React, { useState } from 'react';
import './App.css';
import HomeRent from './Pages/HomeRent.jsx';
import { Routes, Route } from 'react-router-dom';
import Layout from './layout/Layout';
import CategoryCar from './Pages/CategoryCar.jsx';
import DetailCar from './Pages/DetailCar';
import PaymentCar from './Pages/PaymentCar';

function App() {
  const [searchQuery, setSearchQuery] = useState('');

  return (
    <div>
      <Routes>
        <Route path='/' element={<Layout searchQuery={searchQuery} setSearchQuery={setSearchQuery} />}>
          <Route index element={<HomeRent searchQuery={searchQuery}/>} />
          <Route path='Category' element={<CategoryCar />} />
          <Route path='/DetailCar/:id' element={<DetailCar />} />
          <Route path='PaymentCar' element={<PaymentCar />} />
        </Route>
      </Routes>
    </div>
  );
};

export default App;
