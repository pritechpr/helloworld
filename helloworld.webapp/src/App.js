import React, { Component } from "react";
import './App.css';


class App extends Component {

    constructor(props) {
        super(props);
        this.state = {
            helloMsg: "placeholder"
        }
    }

    componentDidMount() {
        return fetch(`https://helloworld-itrellis.you2service.com:44300/api/helloworld`)
            .then((response) => response.text())
            .then((responseBody) => {
                this.setState({
                    helloMsg: responseBody
                })
            })
            .catch((error) => {
                console.error(error);
            })
    }

    render() {
        return (
            <div className="App">
                <div>
                    {this.state.helloMsg}
                </div>
            </div>
            )
    }
}

export default App;
