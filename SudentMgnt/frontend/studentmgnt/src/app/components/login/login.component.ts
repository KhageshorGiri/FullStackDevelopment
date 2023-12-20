import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterLink, RouterLinkActive } from '@angular/router';
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { AuthService } from '../../core/services/auth.service';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [CommonModule, RouterLink, RouterLinkActive, ReactiveFormsModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.scss'
})
export class LoginComponent implements OnInit {
  
  loginForm! : FormGroup;
  _loginService! : AuthService;

  //********************************************************
  // Private Functions 
  //********************************************************
  ngOnInit(): void {
    this.loginForm = new FormGroup({
        userName: new FormControl('',  [Validators.required]),
        password: new FormControl('',  [Validators.required]),
    });
  }

  constructor(loginService: AuthService){
    this._loginService = loginService;
  }

  //********************************************************
  // Public Functions 
  //********************************************************
  onLogin(event: Event){
    event.preventDefault();

    this._loginService.login(this.loginForm.value);
  }

}
