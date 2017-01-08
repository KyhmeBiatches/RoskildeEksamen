import React from 'react'
import ReactDOM from 'react-dom'

class TypeBox extends React.Component {
    
    constructor() {
        super();
        
        this.state = ({ isHidden: false });
    }
    
    componentWillMount() {
        if(this.props.isHidden != null){
            if(this.props.isHidden == 'false'){
                this.state = ({ isHidden: false });
            }
        }
    }
    
    render() {
        return (
            <div className="clearfix">
                    <div className="clearfix">
                        <h4 className="pull-left">Type</h4>
                        <ToggleArrow toggle={this._toggleBtn.bind(this)} isHidden={this.state.isHidden} />
                    </div>
                    {!this.state.isHidden && <TypeToggle />}
            </div>
        );
    }
    
    _toggleBtn() {
        this.setState({isHidden: !this.state.isHidden})
    }
    



}

module.exports = TypeBox;
window.TypeBox = TypeBox;