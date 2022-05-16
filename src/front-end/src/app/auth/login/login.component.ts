import { Component, OnInit } from '@angular/core';
import { AngularFireAuth } from '@angular/fire/compat/auth';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  formGroup = new FormGroup({
    email: new FormControl('', [Validators.email]),
    password: new FormControl('', [Validators.required])
  })

  constructor(
    private router: Router,
    private auth: AngularFireAuth
  ) { }

  ngOnInit(): void {
  }

  authUser(): void {
    this.auth.signInWithEmailAndPassword(this.formGroup.get('email')?.value, this.formGroup.get('password')?.value)
      .then(data => {
        this.router.navigateByUrl('/home');
      })
      .catch(err => console.error(err))
  }

}
