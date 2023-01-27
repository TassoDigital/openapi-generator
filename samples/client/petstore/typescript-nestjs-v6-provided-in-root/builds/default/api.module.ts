import { DynamicModule, Module, Global } from '@nestjs/common';
import { HttpService, HttpModule, HttpModuleOptions } from '@nestjs/axios';
import { Configuration } from './configuration';


import { PetService } from './api/pet.service';
import { StoreService } from './api/store.service';
import { UserService } from './api/user.service';

@Global()
@Module({
  imports:      [ ],
  exports:      [
    PetService,
    StoreService,
    UserService
  ],
  providers: [
    PetService,
    StoreService,
    UserService
  ]
})
export class ApiModule {
    public static forRoot(configurationFactory: () => Configuration): DynamicModule {
        return {
            module: ApiModule,
            providers: [ { provide: Configuration, useFactory: configurationFactory } ],
            imports: [
              HttpModule.registerAsync({
              useFactory: configurationFactory().httpModuleOptionsFactory
            })
      ],
      exports: [HttpModule]
        };
    }

    constructor( httpService: HttpService) { }
}
