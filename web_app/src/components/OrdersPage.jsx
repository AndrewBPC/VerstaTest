import { useEffect, useState } from "react"
import { NavLink } from "react-router-dom"
import { CreateOrderModal } from "./CreateOrder"
import { MDBCard, MDBCardBody, MDBRow } from "mdb-react-ui-kit"
import { FormatDate } from "../utils/FormatDates"



export function OrdersPage(){

    const [orders, setOrders] = useState([])
    const [isLoading, setIsLoading] = useState(true)
    async function fetchOrders(){
        setIsLoading(true)
        const res = await fetch('/api/orders/')
        if(res.ok){
            const data = await res.json()
            data.forEach(it => {
                it.pickupDate = FormatDate(it.pickupDate)
            });
            setOrders(data)
        } else{
            console.log('Ошибка!')
        }
        setIsLoading(false)
    }
    useEffect(()=>{
        fetchOrders()
    },[])
    return <>
        <h3>Заказы</h3>
        {isLoading && <div className="spinner-border text-primary" role="status"/>}
        <CreateOrderModal onAdd={(order) => setOrders(prev => [order, ...prev])}/>
        {/* <NavLink to="/orders/create/">Создать новый заказ</NavLink> */}
        <MDBRow className="gy-2 mt-3">
            {orders?.map((it, i)=><OrderItem key={i} order={it}/>)}
        </MDBRow>
    </>
}
function OrderItem({order}){
    return <>
            <NavLink className="cardLink" to={`/orders/${order.id}`}>

            
                <MDBCard className="col-12" style={{cursor: 'pointer'}}>
                    <MDBCardBody>
                        <h4>Номер заказа: {order.userFriendlyId}</h4>
                        <h5>Отправитель</h5>
                        <p>Город: {order.cityFrom}</p>
                        <p>Адрес: {order.addressFrom}</p>
                        <h5>Получатель</h5>
                        <p>Город: {order.cityTo}</p>
                        <p>Адрес: {order.addressTo}</p>
                        <p>Вес груза: {order.cargoWeight} кг.</p>
                        <p className="fw-bold">Дата отправки: {order.pickupDate}</p>
                    </MDBCardBody>
                    
                </MDBCard>
                </NavLink>
            </>
}