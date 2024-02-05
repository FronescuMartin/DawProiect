import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CompetitieComponent } from './competitie/competitie.component';
import { RezultateComponent } from './rezultat/rezultat.component';
import { PersoaneComponent } from './persoana/persoana.component';

export const routes: Routes = [
  { path: 'competitie', component: CompetitieComponent },
  { path: 'rezultate', component: RezultateComponent },
  { path: 'persoane', component: PersoaneComponent },
  { path: '', redirectTo: '/competitie', pathMatch: 'full' } 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
