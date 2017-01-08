import React from 'react'
import ReactDOM from 'react-dom'

class PriceList extends React.Component {
    
    constructor() {
        super();
        
        this.state = ({items: []})
    }
    
    render(){
        return(
            <form>
                {this._getSelectItems()}
            </form>
        )    
    }
    
    _getSelectItems() {
        return this.state.items.map((item) => { 
            return (
          <SelectItem
            onSelect={this._handleChanges.bind(this)}
            priceString= ""
            index={this.state.items.indexOf(item)} />  
            );
        });
    }
    
    _handleChanges(event, index, value) {
        
    }
    
    
}

module.exports = PriceList;
window.PriceList = PriceList;