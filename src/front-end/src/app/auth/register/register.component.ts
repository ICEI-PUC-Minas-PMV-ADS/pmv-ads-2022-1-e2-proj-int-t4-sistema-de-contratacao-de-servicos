import { Component, OnInit } from '@angular/core';
import { AngularFireAuth } from '@angular/fire/compat/auth';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {
  formGroup = new FormGroup({
    type: new FormControl('', [Validators.required]),
    email: new FormControl('', [Validators.email]),
    name: new FormControl('', [Validators.required, Validators.minLength(3)]),
    password: new FormControl('', [Validators.required])
  })
  constructor(
    private router: Router,
    private auth: AngularFireAuth) { }

  ngOnInit(): void {
  }

  authUser(): void {
    this.auth.createUserWithEmailAndPassword(this.formGroup.get('email')?.value, this.formGroup.get('password')?.value)
      .then(data => {
        this.router.navigateByUrl('/auth/login');
      })
      .catch(err => console.error(err))
  }

}
