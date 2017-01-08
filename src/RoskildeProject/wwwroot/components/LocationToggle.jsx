import React from 'react'
import ReactDOM from 'react-dom'

class LocationToggle extends React.Component {
    
    render() {
        return (
            <div className="row">
                <LocationFromForm />
                <LocationPostalForm />
                <LocationList />
            </div>
        )
    }
    
    
}

module.exports = LocationToggle;
window.LocationToggle = LocationToggle;