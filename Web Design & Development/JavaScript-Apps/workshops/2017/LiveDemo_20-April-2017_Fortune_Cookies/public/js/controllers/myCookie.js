import * as data from 'data';

export function get() {
  return data.getCookies('api/my-cookie');
}
