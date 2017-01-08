import React from 'react'
import ReactDOM from 'react-dom'

class RecentlyItems extends React.Component{

    constructor(atts) {
        super(atts);
        
        this.state = ({ data: [] });   
    }

    componentDidMount() {
        this._loadRecentlyList();
    }

 render() {
        return(
           <div id="recentlyList" className="row">
               <span className="col-md-1"></span>
                   {this._renderRecently()}
               <span className="col-md-1"></span>
           </div>
            )
    }
    _loadRecentlyList() {
        $.ajax({
            url: 'http://localhost:34379/api/itemsapi/get/lastadded',
            datatype: 'json',
            success: function (data) {
                this.setState({ data: data });
            }.bind(this),
            error: function (xhr, status, err) {
                console.error('#GET Error', status, err.toString());
            }.bind(this)
        });
    }
    _renderRecently() {
        return this.state.data.map((item) => {
            return (
                <li key={item.id} className="col-md-2">
                <SearchElement
            id={item.id}
            title={item.title}
            picture={item.pictures[0].imagePath}
            />
                </li>
            );
                });
    }
}


ReactDOM.render(
    <RecentlyItems />,
    document.getElementById('recently-item')
);

module.exports = RecentlyItems;
