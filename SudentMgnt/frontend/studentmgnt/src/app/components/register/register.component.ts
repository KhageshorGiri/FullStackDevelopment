import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterLink, RouterLinkActive } from '@angular/router';
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { AuthService } from '../../core/services/auth.service';


@Component({
  selector: 'app-register',
  standalone: true,
  imports: [CommonModule,RouterLink,RouterLinkActive,ReactiveFormsModule],
  templateUrl: './register.component.html',
  styleUrl: './register.component.scss'
})
export class RegisterComponent implements OnInit {

  registerForm! : FormGroup;
  authService! : AuthService;
  //********************************************************
  // Private Functions 
  //********************************************************

  constructor(authService: AuthService){
   this.authService = authService;
  }

  ngOnInit(): void {
    this.registerForm = new FormGroup({
      userName: new FormControl('', [Validators.required]),
      password: new FormControl('', [Validators.required]),
      conformPassword: new FormControl('', [Validators.required]),
    });
  }



  //********************************************************
  // Public Functions 
  //********************************************************
  onRegister(event: Event){
    event.preventDefault();

    this.authService.registerUser(this.registerForm.value);
  }

}
