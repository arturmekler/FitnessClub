import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { UserProfileComponent } from './user-profile/user-profile.component';
import { UserScheduleComponent } from './user-schedule/user-schedule.component';
import { ChatComponent } from './chat/chat.component';
import { SignUpForClassesComponent } from './sign-up-for-classes/sign-up-for-classes.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';

const routes: Routes = [
    { path: '', component: HomeComponent, pathMatch: 'full' },
    { path: 'counter', component: CounterComponent },
    { path: 'fetch-data', component: FetchDataComponent },
    { path: 'user-profile', component: UserProfileComponent },
    { path: 'user-schedule', component: UserScheduleComponent },
    { path: 'chat', component: ChatComponent },
    { path: 'sign-up-for-classes', component: SignUpForClassesComponent },
    { path: 'login', component: LoginComponent },
    { path: 'register', component: RegisterComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

