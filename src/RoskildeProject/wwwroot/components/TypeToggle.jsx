import React from 'react'
import ReactDOM from 'react-dom'

class TypeToggle extends React.Component {
    
    render() {
        return (
            <div>
                <TypeList />
            </div>
        )
    }
    
    
}

module.exports = TypeToggle;
window.TypeToggle = TypeToggle;
