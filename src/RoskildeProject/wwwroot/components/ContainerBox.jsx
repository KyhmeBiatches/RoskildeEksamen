class ContainerBox extends React.Component {
    render(){
        return(
            <div>
            <SeachBox />
            <CommentBox />
            </div>
            )
    }
}


ReactDOM.render(
<ContainerBox />, document.getElementById("container"))