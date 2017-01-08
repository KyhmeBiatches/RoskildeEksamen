
import React from 'react'
import ReactDOM from 'react-dom'

class SearchItem extends React.Component {

    render() {
        var imagePath = "items/Details/" + this.props.id;
        return(
            <div className="">
                <a href={imagePath}>
                  <div className="itemList row">
                      <div class="col-md-2 imageWrapper">
                          <img className="mainpageImg" src={this.props.picture} alt=""></img>
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
                          description={item.description}
                          created_at={item.created_at}
                          price={item.price}
                          location={item.location} />
        </li>);
        });
        }
        }

        ReactDOM.render(
    <SearchItem />,
    document.getElementById('search-item')
  );


            window.SearchItem = SearchItem;
            module.exports = SearchItem;