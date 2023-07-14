import React ,{ Component } from "react"


export class Student extends Component{

    static displayName = Student.name;
    render(){
        return (
            <>
                <h1>Hello student</h1>
            </>
        );
    }
}