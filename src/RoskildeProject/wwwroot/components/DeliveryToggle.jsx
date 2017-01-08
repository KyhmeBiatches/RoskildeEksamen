import React from 'react'
import ReactDOM from 'react-dom'

class DeliveryToggle extends React.Component {
    
    render() {
        return (
            <div>
                <DeliveryList />
            </div>
        )
    }
    
    
}

module.exports = DeliveryToggle;
window.DeliveryToggle = DeliveryToggle;