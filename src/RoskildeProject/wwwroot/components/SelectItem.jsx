import React from 'react'
import ReactDOM from 'react-dom'

class SelectItem extends React.Component {
    
    render() {
        <div className="col-md-12">
            <label><input type="checkbox" value="">{this.props.priceString}</label>
        </div>
    }
    
}

module.exports = SelectItem;
window.SelectItem = SelectItem;