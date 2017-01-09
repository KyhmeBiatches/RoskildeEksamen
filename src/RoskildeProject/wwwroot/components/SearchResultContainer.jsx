import React from 'react'
import ReactDOM from 'react-dom'


class SearchResultContainer extends React.Component{

    constructor(atts) {
        super(atts);
        
        this.state = ({ data: [] });   
    }

    componentDidMount() {
        this._loadItemList();
    }

    render() {
        return(
           <div className="SearchResult">
               <h1>Items from web api</h1>
                  
    <div>
        <div className="btn-group" role="group" aria-label="...">
            <button type="button" className="btn btn-default">Alle</button>
            <button type="button" className="btn btn-default">Privat</button>
            <button type="button" className="btn btn-default">Forhandler</button>
        </div>
        <div className="dropdown pull-right">
            <button className="btn btn-default dropdown-toggle" type="button" id="dropdownMenu1" data-toggle="dropdown" aria-haspopup="true" aria-expanded="true">
                Vis som list
                <span className="caret"></span>
            </button>
            <ul className="dropdown-menu pull-right" aria-labelledby="dropdownMenu1">
                <li><a href="#">Anden visning</a></li>
            </ul>
        </div>
        <div className="dropdown pull-right">
            <button className="btn btn-default dropdown-toggle" type="button" id="dropdownMenu1" data-toggle="dropdown" aria-haspopup="true" aria-expanded="true">
                Bedste match
                <span className="caret"></span>
            </button>
            <ul className="dropdown-menu pull-right" aria-labelledby="dropdownMenu1">
                <li><a href="#">Pris høj</a></li>
                <li><a href="#">Pris lav</a></li>
                <li><a href="#">Nærmest</a></li>
            </ul>
        </div>
    </div>

    <div>
        <span className="badge">Annoncer(120)</span>
    </div>
    <div className="media description-border">
        <div>
            <div className="media-body">
                <a href="#">
                    <h6 className="media-middle col-md-4 title-filter">Beskrivelse</h6>
                </a>
            </div>
            <div className="media-body">
                <a href="#">
                    <h6 className="pull-right media-middle col-md-4 date-filter">Dato</h6>
                </a>
            </div>
            <div className="media-body">
                <a href="#">
                    <h6 className="pull-right media-middle col-md-4">Pris</h6>
                </a>
            </div>
        </div>
    </div>
               <ul>
                   {this._renderItems()}
               </ul>
           </div> 
            )
    }

    _loadItemList() {
        $.ajax({
            url: 'http://localhost:34379/api/itemsapi',
            datatype: 'json',
            success: function (data) {
                this.setState({ data: data });
            }.bind(this),
            error: function (xhr, status, err) {
                console.error('#GET Error', status, err.toString());
            }.bind(this)
        });
    }

    _renderItems() {
        return this.state.data.map((item) => {
            return (
                <li key={item.id}>
                <SearchItem
            id={item.id}
            title={item.title}
            created_at={item.created_at}
            price={item.price}
            location={item.location}
            picture={item.pictures[0].imagePath}
            />
                </li>
            );
                    });
    }
}

module.exports = SearchResultContainer;

ReactDOM.render(
  <SearchResultContainer />,
  document.getElementById('search-box')
);