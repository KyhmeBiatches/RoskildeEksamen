
import React from 'react'
import ReactDOM from 'react-dom'

class SearchItem extends React.Component {

    render() {
        var itemPath = "Details/" + this.props.id;
        return(
            <div className="">
                <a href={itemPath}>
                  <div className="itemsList row">
                      <div className="col-md-2 imageWrapper">
                          <img className="" src={this.props.picture} alt=""></img>
                      </div>
                      <div className="col-md-9">
                          <h3>{this.props.title}</h3>
                          <div className="row">
                               <div className="col-md-6">
                                    <p className="whiteText">{this.props.description}</p>
                               </div>
                               <div className="col-md-3">
                                    <h4 className="whiteText">{this.props.created_at}</h4>
                               </div>
                               <div className="col-md-3">
                                    <h4 className="pull-right whiteText">{this.props.price}</h4>
                               </div>
                               <div className="col-md-12">
                                    <h5 className="whiteText">{this.props.location}</h5>
                               </div>
                          </div>
                      </div>
                  </div>
                </a>
                <hr/>
            </div>
        );
        }
                          
        }

        ReactDOM.render(
    <SearchItem />,
    document.getElementById('search-item')
  );


            window.SearchItem = SearchItem;
            module.exports = SearchItem;