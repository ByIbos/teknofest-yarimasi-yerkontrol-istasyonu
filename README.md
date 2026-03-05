# 🛰️ Teknofest Kontrol İstasyonu

> Teknofest yarışmalarına katılan takımlar için geliştirilmiş, seri port haberleşmesi ve Teknofest API entegrasyonu sunan açık kaynaklı kontrol istasyonu.

---

## 📌 Hakkında

Bu proje, Teknofest yarışmacılarının makine sistemleriyle **seri port üzerinden haberleşmesini** sağlamak, anlık verileri görselleştirmek ve **Teknofest'in sunduğu API'ye bağlanarak** yarışma verilerini almak amacıyla geliştirilmiştir.

Proje şu an birden fazla yarışma dalına entegre edilmiş olup aktif olarak geliştirilmeye devam etmektedir. İlerleyen dönemlerde daha fazla yarışma kategorisini kapsayacak şekilde genişletilecektir.

---

## ✨ Özellikler

- 🔌 **Seri Port Bağlantısı** — Yarışma makineleriyle gerçek zamanlı seri port haberleşmesi
- 📡 **Teknofest API Entegrasyonu** — Sunucudan yarışma verisi alma
- 📊 **Veri Görselleştirme** — Alınan verilerin ekranda anlık olarak izlenmesi
- 🏁 **Çoklu Yarışma Desteği** — Birden fazla Teknofest kategorisi için entegrasyon

---

## 🚀 Kurulum

```bash
git clone https://github.com/ByIbos/<repo-adı>.git
cd <repo-adı>
pip install -r requirements.txt
```

---

## ⚙️ Kullanım

```bash
python main.py
```

Seri port ayarlarını ve API bilgilerini `config.yaml` dosyasından düzenleyebilirsiniz.

---

## 🗺️ Yol Haritası

- [x] Seri port bağlantısı ve veri alma
- [x] Teknofest API bağlantısı
- [x] Veri görselleştirme
- [ ] Daha fazla yarışma kategorisi desteği
- [ ] GUI arayüzü
- [ ] Loglama ve kayıt sistemi

---

## 📄 Lisans

MIT License — dilediğiniz gibi kullanabilirsiniz.

---

## 🙏 Teşekkür

Bu kontrol istasyonunu kullanan takımların **ByIbos tarafından geliştirilen Kontrol İstasyonu**ndan yararlandıklarını belirtmeleri rica olunur.

---

<div align="center">
  <sub>Built with ❤️ by <a href="https://github.com/ByIbos">ByIbos</a></sub>
</div>
