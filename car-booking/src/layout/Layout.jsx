import React, { useState } from 'react';
import Header from '../components/Header';
import Footer from '../components/Footer';
import { Outlet } from 'react-router-dom';

const Layout = () => {
  const [searchQuery, setSearchQuery] = useState(''); // Создаем состояние для поиска

  return (
    <div>
      {/* Передаем состояние и обработчик в Header */}
      <Header searchQuery={searchQuery} setSearchQuery={setSearchQuery} />
      <main>
        {/* Передаем searchQuery в дочерние компоненты через контекст или пропсы */}
        <Outlet context={{ searchQuery }} />
      </main>
      <Footer />
    </div>
  );
};

export default Layout;