import React from 'react'
import ReactDOM from 'react-dom'

class PriceToggle extends React.Component {
    
    render() {
        return (
            <div className="row">
                <PriceForm />
            </div>
        )
    }
    
    
}

module.exports = PriceToggle;
window.PriceToggle = PriceToggle;