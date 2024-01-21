import { MDBInput, MDBModal, MDBModalBody, MDBModalContent, MDBModalDialog, MDBModalFooter, MDBModalHeader, MDBModalTitle, MDBRow } from "mdb-react-ui-kit"
import { useState } from "react"


export function CreateOrderModal({onAdd}){
    const [modal, setModal] = useState(false)
    async function addToServer(e){
        e.preventDefault()
        const fd = new FormData(e.target)
        const res = await fetch('/api/orders/',{
            method: 'PUT',
            body: fd,
        })
        if(res.ok){
            // ok
            onAdd(await res.json())
        }
    }

    return <>
    <button className="btn btn-primary" onClick={()=>setModal(true)}>Добавить заказ</button>
    <MDBModal open={modal} setOpen={setModal}>
        <MDBModalDialog>
            <MDBModalContent>
                <MDBModalHeader><MDBModalTitle>Создать новый заказ</MDBModalTitle></MDBModalHeader>
                <form onSubmit={addToServer}>
                    <MDBModalBody>
                    <MDBRow className="gy-2">
                    <MDBInput required name="cityFrom" placeholder="Санкт-Петербург" label="Город отправления"/>
                    <MDBInput required name="addressFrom" placeholder="Санкт-Петербург" label="Адрес отправления"/>
                    <MDBInput required name="cityTo" placeholder="Санкт-Петербург" label="Город получателя"/>
                    <MDBInput required name="addressTo" placeholder="Санкт-Петербург" label="Адрес получателя"/>
                    <MDBInput required name="cargoWeight" min={0} type="number" placeholder="2" label="Вес посылки"/>
                    <MDBInput required name="pickupDate" type="date" defaultValue={new Date().toISOString().substring(0,10)} label="Дата отправки"/>
                    </MDBRow>
                    
               
                    
                
                </MDBModalBody>
                <MDBModalFooter>
                    <button className="btn btn-danger" onClick={()=> setModal(false)}>Отмена</button>
                    <button className="btn btn-success">Добавить!</button>
                </MDBModalFooter>
                
        </form>
            </MDBModalContent>
        </MDBModalDialog>
        
    </MDBModal>
        {/* <h3>Форма для создания заказа</h3> */}
        
    </>
}