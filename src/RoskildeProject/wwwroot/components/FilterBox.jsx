import React from 'react'
import ReactDOM from 'react-dom'

class FilterBox extends React.Component {
    
    constructor(atts) {
        super(atts);
        
    }
    
    render() {
        return(
            <div className="">
                <h2>Filter </h2>
                <CategoryBox isHidden={'false'}/>
                <LocationBox isHidden={'false'}/>
                <PriceBox isHidden={'false'}/>
                <DeliveryBox isHidden={'true'} />
                <TypeBox isHidden={'true'}/>
            </div>
        )
    }
    
    
}


ReactDOM.render(<FilterBox />, document.getElementById("filterbox"));

module.exports = FilterBox;