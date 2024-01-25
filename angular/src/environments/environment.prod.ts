import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'NexusCrafter',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44378/',
    redirectUri: baseUrl,
    clientId: 'NexusCrafter_App',
    responseType: 'code',
    scope: 'offline_access NexusCrafter',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44372',
      rootNamespace: 'OrgAE.NexusCrafter',
    },
  },
} as Environment;
