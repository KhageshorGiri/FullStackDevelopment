import { Injectable } from "@angular/core";

@Injectable({
    providedIn: 'root'
})
export class AuthService{
 
    // register service method
    registerUser(newUser: any){
        console.log(newUser);
    }

    //login service method
    login(user: any){
        console.log(user);
    }
    
}