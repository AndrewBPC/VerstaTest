import logo from './logo.svg';
import './App.css';
import { NavLink, Route, Routes } from 'react-router-dom';
import { OrdersPage } from './components/OrdersPage';
import { CreateOrderPage } from './components/CreateOrder';
import { OrderPage } from './components/OrderPage';
import { MDBContainer } from 'mdb-react-ui-kit';
import { HomePage } from './components/HomePage';

function App() {
  return (
    <>
    <MDBContainer>
    <Routes>
        <Route path='/' element={<HomePage/>}/>
        <Route path='/orders/' element={<OrdersPage/>}/>
        {/* <Route path='/orders/create' element={<CreateOrderPage/>}/> */}
        <Route path='/orders/:id' element={<OrderPage/>}/>
      </Routes>
    </MDBContainer>
      
    </>
  );
}

export default App;
