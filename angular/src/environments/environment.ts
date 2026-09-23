import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'BookingManagememtSystem4',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44336/',
    redirectUri: baseUrl,
    clientId: 'BookingManagememtSystem4_App',
    responseType: 'code',
    scope: 'offline_access BookingManagememtSystem4',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44336',
      rootNamespace: 'Acme.BookingManagememtSystem4',
    },
  },
} as Environment;
